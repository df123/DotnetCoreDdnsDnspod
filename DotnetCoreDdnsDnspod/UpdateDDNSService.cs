using DotnetCoreDdnsDnspod.JsonData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetCoreDdnsDnspod
{
    public class UpdateDDNSService : IHostedService, IDisposable
    {
        private readonly ILogger<UpdateDDNSService> _logger;
        private readonly IConfiguration _config;
        private readonly IGetIP _getIP;
        private UserData _ud;
        private Timer _timer;
        private Dnspod _dnspod;
        private RecordData _recordData;

        public UpdateDDNSService(ILogger<UpdateDDNSService> logger, IServiceProvider serviceProvider,IGetIP getIP)
        {
            _logger = logger;
            _config = serviceProvider.GetService<IConfiguration>();
            _getIP = getIP;

            _dnspod = new Dnspod();

            UserData ud = new UserData();
            _config.GetSection("UserData").Bind(ud);
            _ud = ud;

            _recordData = _dnspod.RecordList(ud.Token, ud.Domain);
            if(!_recordData.status.code.Equals("1") || _recordData == null)
            {
                throw new Exception("未获得记录");
            }
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(_ud.IntervalTime));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            string ip = _getIP.GetIP(_ud.GetIPUrl);
            foreach (var item in _recordData.records)
            {
                if (item.type.Equals("A") && (!item.value.Equals(ip)) && (ip != null) && (ip != ""))
                {
                    _dnspod.Ddns(_ud.Token, _ud.Domain, item.id, item.name, item.line, ip);
                    _logger.LogInformation($"{DateTime.Now}\t主机类型：{item.name} 记录类型：{item.type} 的原地址为：{item.value} 更新后的地址为：{ip}");
                    item.value = ip;
                }
                else if(item.value.Equals(ip))
                {
                    _logger.LogInformation($"{DateTime.Now}\t主机类型：{item.name}的记录地址为：{item.value} 网络获取的ip地址为：{ip}");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
