# Metro.Logging
更新到.net core 3.0
使用方法

Program文件 
增加:

webBuilder.ConfigureLogging(builder => builder.AddFile());

Startup文件

ConfigureServices方法增加:
 services.AddLoggingFileUI();
 services.AddRazorPages();
Configure方法增加:
路由节点增加:endpoints.MapRazorPages();

appsettings.json文件
"Logging": {
    "File": {
      "LogLevel": {
        "Default": "Information"
      }
    }
  }
就可以兼容 asp.net core 3.0
