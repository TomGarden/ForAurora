本代码的由来：一个叫霞的人提的需求。

For Aurora

功能：基于C#试题管理

----

从本项目来看我对一个项目的把控还有上升的空间

MVP  面向接口

开发环境 Win7_64+VS2015+MySQL5.7+Navicat

运行环境 ：配置好MySQL的基础环境——用户名：root 密码：root

```java
//数据库连接字符串
public static string Conn = "Database='for_aurora';Data Source='localhost';User Id='root';Password='root';charset='utf8';pooling=true";
```
Other文件夹内有数据库备份文件for_aurora.sql(用Navicat)可以方便的导入
Other/Doc 存放开发过程中的一些笔记和草稿

- 课程管理界面
- ![课程管理界面](https://github.com/TomGarden/ForAurora/Image1.png)

- 教师管理界面
- ![教师管理界面](https://github.com/TomGarden/ForAurora/images/Image2.png)

- 知识点试题管理界面
- ![知识点试题管理界面](https://github.com/TomGarden/ForAurora/images/Image4.png)
