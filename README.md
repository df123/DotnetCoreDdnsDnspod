# DotnetCoreDdnsDnspod
适用于dnspod的ddns，使用.net core 3.1编写。

## 介绍
使用.net core 3.1编写的适用于dnspod的ddns更新程序。更新@和www主机类型的IP地址。

## 安装
1.dotnet core 3.1安装参考 [微软官方](https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-debian10)  
2.下载release文件并解压

## 使用
1.编辑UserData.json  
2.Linux版，执行dotnet DotnetCoreDdnsDnspod.dll；windows版双击DotnetCoreDdnsDnspod.exe

## 配置文件说明
1.Token，在dnspod中申请，同时填入ID和token，两者用逗号隔开；  
2.Domain，需要更新ip地址的域名；  
3.IntervalTime，程序检查ip地址时间间隔，单位为秒；  
4.GetIPUrl，获取用户公网ip地址的链接。 
