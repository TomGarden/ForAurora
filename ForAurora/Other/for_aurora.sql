/*
Navicat MySQL Data Transfer

Source Server         : C#试题库管理系统
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : for_aurora_1

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-04-28 15:37:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for account
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `username` char(32) NOT NULL COMMENT '账号(*)',
  `pwd` char(32) NOT NULL COMMENT '密码(*)',
  `secret_question` varchar(32) NOT NULL COMMENT '密保问题',
  `secret_answer` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='账户';

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', '2017-03-30 12:41:35', '2017-03-30 12:41:37', '测试账号', '1', '1', '1', '1');

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(64) NOT NULL COMMENT '课程名',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='课程';

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES ('0cbe3b4c3de642259cd7b6c4674e0acc', '2017-04-28 11:08:53', '2017-04-28 11:08:53', null, '有待完善');
INSERT INTO `course` VALUES ('0fe5207c6dcf4a2a93e2af00baa7263b', '2017-04-13 08:54:53', '2017-04-13 08:54:53', '《计算机组成原理》以冯·诺依曼计算机模型为出发点，介绍单机系统范围内计算机的组织结构和工作原理。', '计算机组成原理');
INSERT INTO `course` VALUES ('39ba892ec130424e9bdb7717f471850d', '2017-04-13 08:51:44', '2017-04-13 08:51:44', 'Java应用程序开发是这门课程实用价值非常大，对就业有很大帮助。', 'Java应用程序开发');
INSERT INTO `course` VALUES ('492314f001a746779246f99778d68155', '2017-04-13 08:57:54', '2017-04-13 08:57:54', '汇编语言（assembly language）是一种用于电子计算机、微处理器、微控制器或其他可编程器件的低级语言，亦称为符号语言。', '汇编语言');
INSERT INTO `course` VALUES ('e171b2e910af48b09e32fef45bc372fb', '2017-04-28 11:15:55', '2017-04-28 11:15:55', null, '有待完善');
INSERT INTO `course` VALUES ('fefb72d354a34367aa083e39b20c6d55', '2017-04-27 15:46:48', '2017-04-27 15:46:48', '语文，是语言以及文学、文化的简称，包括口头语言和书面语言；口头语言较随意，直接易懂，而书面语言讲究准确和语法；文学包括中外古今文学等。', '语文');

-- ----------------------------
-- Table structure for course_spread_knowledge_point
-- ----------------------------
DROP TABLE IF EXISTS `course_spread_knowledge_point`;
CREATE TABLE `course_spread_knowledge_point` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_knowledge_point_id` char(32) NOT NULL COMMENT '知识点ID(*）onUpdate=casade;onDelete=casade',
  `uk_course_id` char(32) NOT NULL COMMENT '课程ID(*)onUpdate=casade;onDelete=casade',
  PRIMARY KEY (`id`),
  KEY `uk_knowkedge_point_id` (`uk_knowledge_point_id`),
  KEY `course_spread_knowledge_point_ibfk_2` (`uk_course_id`),
  CONSTRAINT `course_spread_knowledge_point_ibfk_1` FOREIGN KEY (`uk_knowledge_point_id`) REFERENCES `knowledge_point` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `course_spread_knowledge_point_ibfk_2` FOREIGN KEY (`uk_course_id`) REFERENCES `course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='课程传播知识点';

-- ----------------------------
-- Records of course_spread_knowledge_point
-- ----------------------------
INSERT INTO `course_spread_knowledge_point` VALUES ('002c46d182a44f9e9e03f0cd279a6179', '2017-04-13 09:53:44', '2017-04-13 09:53:44', null, 'f6b554f4f8644d7bb4e9b9d9e1fc53ea', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('074ad45ddf7e41b8b319c064cc4f090b', '2017-04-13 09:50:01', '2017-04-13 09:50:01', null, '7bdfed3a1e6c4234a8085b9229db8a8d', '39ba892ec130424e9bdb7717f471850d');
INSERT INTO `course_spread_knowledge_point` VALUES ('1085ca6d861c4f7d9c84bbd53c715bc9', '2017-04-13 09:55:02', '2017-04-13 09:55:02', null, 'b818c472da8640f8a21b2d2ea7fddfea', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('19e498dee6b34c30834dbdfb4c589242', '2017-04-13 09:54:12', '2017-04-13 09:54:12', null, '5754938e61774c62a10ddfdef07742e1', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('1d4f901cfa2141ef9c5b34ee77957b78', '2017-04-13 09:54:23', '2017-04-13 09:54:23', null, '462a760a3b964c4e802e0c3d856205e0', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('208733f288d94434ba5fe4c4b0730900', '2017-04-13 09:54:57', '2017-04-13 09:54:57', null, 'ecb4b1627cc84d608603decf1c55b285', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('3647e02fee0e471793fbd34a6e307170', '2017-04-27 15:53:04', '2017-04-27 15:53:04', null, '4e32accb9d77411a8d8dbeba5846d723', 'fefb72d354a34367aa083e39b20c6d55');
INSERT INTO `course_spread_knowledge_point` VALUES ('36f05efddbd1423d8bbe41e5204b74d3', '2017-04-13 09:52:20', '2017-04-13 09:52:20', null, 'a9cfbb5802794ffa99e0ea33710d0961', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('46fc93214d444b51aad5abb05859644f', '2017-04-13 09:55:32', '2017-04-13 09:55:32', null, '1a48cbd37cef4b3b82fb625864e28770', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('5a18d9b26d1f42bb95734e23d332fac8', '2017-04-13 09:55:13', '2017-04-13 09:55:13', null, 'f2e579e7e91f4a9686a4a5a1d5a4406f', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('61bc3a471b2d4ba38eedea88b0a56e3c', '2017-04-13 09:51:15', '2017-04-13 09:51:15', null, '1dcd411917c84bb59de3ca367ff06714', '39ba892ec130424e9bdb7717f471850d');
INSERT INTO `course_spread_knowledge_point` VALUES ('675825ee331a4afcae526dedc6816c5e', '2017-04-13 09:48:24', '2017-04-13 09:48:24', null, '9c976a30f629427fa7b718c1c9a9ec9a', '39ba892ec130424e9bdb7717f471850d');
INSERT INTO `course_spread_knowledge_point` VALUES ('6da287a7e5c54f4189321ca000cbc776', '2017-04-13 09:55:09', '2017-04-13 09:55:09', null, '74a3d4c5535f401b98b88d0c656b8212', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('a6b44a17d5024d96971bb08feac59353', '2017-04-13 09:53:33', '2017-04-13 09:53:33', null, 'd93fcd9754e6465d89e535056f0b36b9', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('b9f5f9c4cfa44ce483c64fc69e5d1b46', '2017-04-13 09:53:53', '2017-04-13 09:53:53', null, 'd93afb6b4abe4f5a8adc939b6ade45c2', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('edb3ff83a82745729994cd9f6dd8b2ff', '2017-04-27 15:50:39', '2017-04-27 15:50:39', null, '65ee25a5e9aa43348f04b80665f6f13f', 'fefb72d354a34367aa083e39b20c6d55');
INSERT INTO `course_spread_knowledge_point` VALUES ('efb6eab12e30460eb6a707744889564d', '2017-04-27 15:53:20', '2017-04-27 15:53:20', null, '53bff7d297f6476bbd8ea326f947d018', 'fefb72d354a34367aa083e39b20c6d55');
INSERT INTO `course_spread_knowledge_point` VALUES ('f906676c7dc54bf29a7eefb434511eb8', '2017-04-13 09:53:23', '2017-04-13 09:53:23', null, 'c8ef53a98bd64d798b10e80e710c1dc0', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('fd383683d6c741e29061921a4cc7c17a', '2017-04-13 09:55:16', '2017-04-13 09:55:16', null, 'e509352c51d34ddd829f672b534086c5', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('feb2d3033de54f26b9ab33b8ddb34413', '2017-04-13 09:56:36', '2017-04-13 09:56:36', null, '8c8b1f12503c47ab8690e499e3b2e3a1', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `course_spread_knowledge_point` VALUES ('ff2917359fa9406dbbf74977e94bc5c1', '2017-04-13 09:54:30', '2017-04-13 09:54:30', null, '5057679ccdfb474d86148eeed8ecbaac', '0fe5207c6dcf4a2a93e2af00baa7263b');

-- ----------------------------
-- Table structure for examination_papers
-- ----------------------------
DROP TABLE IF EXISTS `examination_papers`;
CREATE TABLE `examination_papers` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(64) NOT NULL COMMENT '试卷名',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='试卷';

-- ----------------------------
-- Records of examination_papers
-- ----------------------------

-- ----------------------------
-- Table structure for knowledge_point
-- ----------------------------
DROP TABLE IF EXISTS `knowledge_point`;
CREATE TABLE `knowledge_point` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(64) NOT NULL COMMENT '知识点名称',
  `uk_upper_knowledge_point_id` char(32) DEFAULT NULL COMMENT '上层知识点id:如果值为null表示是根知识点，否则是子知识点。—onUpdate=onDelete=Cascade',
  PRIMARY KEY (`id`),
  KEY `uk_upper_knowledge_point_id` (`uk_upper_knowledge_point_id`),
  CONSTRAINT `knowledge_point_ibfk_1` FOREIGN KEY (`uk_upper_knowledge_point_id`) REFERENCES `knowledge_point` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='知识点';

-- ----------------------------
-- Records of knowledge_point
-- ----------------------------
INSERT INTO `knowledge_point` VALUES ('1a48cbd37cef4b3b82fb625864e28770', '2017-04-13 09:55:32', '2017-04-13 09:55:32', '', 'Override/Overload', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('1dcd411917c84bb59de3ca367ff06714', '2017-04-13 09:51:15', '2017-04-13 09:51:15', '', 'Character 类', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('2', '2017-04-11 17:21:41', '2017-04-11 17:21:39', '通过UI修改成功了', '牛顿运动定律', 'root');
INSERT INTO `knowledge_point` VALUES ('21', '2017-04-12 16:25:16', '2017-04-12 16:25:16', '格式可以保存的\n   水电费\n  阿斯顿发圣诞', '牛一', '2');
INSERT INTO `knowledge_point` VALUES ('22', '2017-04-09 07:52:35', '2017-04-09 07:52:37', null, '牛二', '2');
INSERT INTO `knowledge_point` VALUES ('23', '2017-04-09 07:52:35', '2017-04-09 07:52:37', null, '牛三', '2');
INSERT INTO `knowledge_point` VALUES ('3fab6bad521f43a2bcbf6b9429dad946', '2017-04-11 16:44:58', '2017-04-11 16:44:58', 'course_spread_knowledge_point.uk_knowkedge_point_id', '手动根节点', 'root');
INSERT INTO `knowledge_point` VALUES ('462a760a3b964c4e802e0c3d856205e0', '2017-04-13 09:54:23', '2017-04-13 09:54:23', '', 'Scanner 类', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('4e32accb9d77411a8d8dbeba5846d723', '2017-04-27 15:53:04', '2017-04-27 15:53:04', '', '来自命运的东西并不脱离本性', 'root');
INSERT INTO `knowledge_point` VALUES ('5057679ccdfb474d86148eeed8ecbaac', '2017-04-13 09:54:30', '2017-04-13 09:54:30', '', '异常处理', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('53bff7d297f6476bbd8ea326f947d018', '2017-04-27 15:53:20', '2017-04-27 15:53:20', '', '享受那你认为是最好的东西的快乐', '4e32accb9d77411a8d8dbeba5846d723');
INSERT INTO `knowledge_point` VALUES ('563962b30ed445db99abc050ed75b669', '2017-04-11 16:23:37', '2017-04-11 16:23:37', '备注', '牛四', '2');
INSERT INTO `knowledge_point` VALUES ('5754938e61774c62a10ddfdef07742e1', '2017-04-13 09:54:12', '2017-04-13 09:54:12', '', 'Stream、File、IO', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('65ee25a5e9aa43348f04b80665f6f13f', '2017-04-27 15:50:39', '2017-04-27 15:50:39', '', '品质闪耀在良好的传承中', 'root');
INSERT INTO `knowledge_point` VALUES ('74a3d4c5535f401b98b88d0c656b8212', '2017-04-13 09:55:09', '2017-04-13 09:55:09', '', '多态', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('7bdfed3a1e6c4234a8085b9229db8a8d', '2017-04-13 09:50:01', '2017-04-13 09:50:01', 'Java有一系列功能强大的可重用类，分别在不同的包中，这些包按功能可划分为：语言包java.lang(language)、输入/输出包java.io、实用程序包java.util(utility)、小应用程序包java.applet、图形用户接口包java.swing、java.awt和网络包java.net等。有时人们称前三种包为java的基础包。', 'Java常用类', 'root');
INSERT INTO `knowledge_point` VALUES ('8c8b1f12503c47ab8690e499e3b2e3a1', '2017-04-13 09:56:36', '2017-04-13 09:56:36', 'Java 连接 MySQL 需要驱动包，最新版下载地址为：http://dev.mysql.com/downloads/connector/j/，解压后得到jar库文件，然后在对应的项目中导入该库文件。', 'Java MySQL 连接', 'root');
INSERT INTO `knowledge_point` VALUES ('9c976a30f629427fa7b718c1c9a9ec9a', '2017-04-23 08:47:06', '2017-04-23 08:47:06', '面向对象(Object Oriented,OO)是软件开发方法。面向对象的概念和应用已超越了程序设计和软件开发，扩展到如数据库系统、交互式界面、应用结构、应用平台、分布式系统、网络管理结构、CAD技术、人工智能等领域。面向对象是一种对现实世界理解和抽象的方法，是计算机编程技术发展到一定阶段后的产物。', 'Java面向对象', 'root');
INSERT INTO `knowledge_point` VALUES ('a9cfbb5802794ffa99e0ea33710d0961', '2017-04-13 09:52:20', '2017-04-13 09:52:20', '', 'String 类', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('acaf15f0a0c44380a51bd990ba30a01e', '2017-04-11 16:24:09', '2017-04-11 16:24:09', '', 'UI添加的根知识点', 'root');
INSERT INTO `knowledge_point` VALUES ('b818c472da8640f8a21b2d2ea7fddfea', '2017-04-13 09:55:02', '2017-04-13 09:55:02', '', '继承', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('c8ef53a98bd64d798b10e80e710c1dc0', '2017-04-13 09:53:23', '2017-04-13 09:53:23', '', 'StringBuffer 类', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('d93afb6b4abe4f5a8adc939b6ade45c2', '2017-04-13 09:53:53', '2017-04-13 09:53:53', '', '正则表达式', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('d93fcd9754e6465d89e535056f0b36b9', '2017-04-13 09:53:33', '2017-04-13 09:53:33', '', '数组', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('e509352c51d34ddd829f672b534086c5', '2017-04-13 09:55:16', '2017-04-13 09:55:16', '', '包', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('ecb4b1627cc84d608603decf1c55b285', '2017-04-13 09:54:57', '2017-04-13 09:54:57', '', '封装', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('f2e579e7e91f4a9686a4a5a1d5a4406f', '2017-04-13 09:55:13', '2017-04-13 09:55:13', '', '接口', '9c976a30f629427fa7b718c1c9a9ec9a');
INSERT INTO `knowledge_point` VALUES ('f6b554f4f8644d7bb4e9b9d9e1fc53ea', '2017-04-13 09:53:44', '2017-04-13 09:53:44', '', '日期时间', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point` VALUES ('many knowls', '2017-04-14 15:52:39', '2017-04-14 15:52:39', null, '多知识点', 'root');
INSERT INTO `knowledge_point` VALUES ('none knowls', '2017-04-14 15:52:47', '2017-04-14 15:52:48', null, '未关联知识点', 'root');
INSERT INTO `knowledge_point` VALUES ('root', '2017-04-09 07:51:10', '2017-04-09 07:51:11', null, '根', 'root');

-- ----------------------------
-- Table structure for knowledge_point_compose_problem
-- ----------------------------
DROP TABLE IF EXISTS `knowledge_point_compose_problem`;
CREATE TABLE `knowledge_point_compose_problem` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_problem_id` char(32) NOT NULL COMMENT '试题ID(*）onUpdate=casade;onDelete=casade',
  `uk_knowledge_point_id` char(32) NOT NULL COMMENT '知识点ID(*)onUpdate=casade;onDelete=casade',
  PRIMARY KEY (`id`),
  KEY `uk_problem_id` (`uk_problem_id`),
  KEY `knowledge_point_compose_problem_ibfk_2` (`uk_knowledge_point_id`),
  CONSTRAINT `knowledge_point_compose_problem_ibfk_1` FOREIGN KEY (`uk_problem_id`) REFERENCES `problem` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `knowledge_point_compose_problem_ibfk_2` FOREIGN KEY (`uk_knowledge_point_id`) REFERENCES `knowledge_point` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='知识点组成试题';

-- ----------------------------
-- Records of knowledge_point_compose_problem
-- ----------------------------
INSERT INTO `knowledge_point_compose_problem` VALUES ('293b3c3cbf4d4fbb836a7fcfe1350dd9', '2017-04-14 16:22:52', '2017-04-14 16:22:52', null, '2fc8dc03576d4d8da2679f84b558587e', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('31e22cd601214b05865c0c8158a6851b', '2017-04-28 09:49:14', '2017-04-28 09:49:14', null, '2fc8dc03576d4d8da2679f84b558587e', 'f2e579e7e91f4a9686a4a5a1d5a4406f');
INSERT INTO `knowledge_point_compose_problem` VALUES ('3651b68b8ddd43f399b5e2c202fb2270', '2017-04-14 16:22:34', '2017-04-14 16:22:34', null, '2f93e81ff01e428187cc48befc8d4993', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('3ed60167e1cb455681e4a159ac8ef3d6', '2017-04-23 17:33:18', '2017-04-23 17:33:18', null, 'f874aedfee0a4e7283dc35db097d5845', 'f2e579e7e91f4a9686a4a5a1d5a4406f');
INSERT INTO `knowledge_point_compose_problem` VALUES ('46d856105d344a628867ac2a8e1bd78a', '2017-04-14 16:23:16', '2017-04-14 16:23:16', null, '4f12aeefd4fe4ff6801d88271e7f1c23', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('4c780d7d93a64c5e8482c6d90a70dcec', '2017-04-28 09:49:14', '2017-04-28 09:49:14', null, '2fc8dc03576d4d8da2679f84b558587e', 'b818c472da8640f8a21b2d2ea7fddfea');
INSERT INTO `knowledge_point_compose_problem` VALUES ('88d15ce9d50e496a829bb8aebf330957', '2017-04-23 17:33:18', '2017-04-23 17:33:18', null, 'f874aedfee0a4e7283dc35db097d5845', 'e509352c51d34ddd829f672b534086c5');
INSERT INTO `knowledge_point_compose_problem` VALUES ('96d97e4afbb2414f80aa6a2bae7f948d', '2017-04-28 09:49:14', '2017-04-28 09:49:14', null, '2fc8dc03576d4d8da2679f84b558587e', 'ecb4b1627cc84d608603decf1c55b285');
INSERT INTO `knowledge_point_compose_problem` VALUES ('994c6933400a456183b512918ac01531', '2017-04-14 16:23:08', '2017-04-14 16:23:08', null, 'be6d73a26f164459a3e2933f17646bd4', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('aa06898e879f447181ed694bd802225f', '2017-04-14 16:23:36', '2017-04-14 16:23:36', null, '5b14a88381e84fa1a21ae4d3e6897be2', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('b421fb14855e49458c9423314df2142e', '2017-04-23 17:33:18', '2017-04-23 17:33:18', null, 'f874aedfee0a4e7283dc35db097d5845', 'ecb4b1627cc84d608603decf1c55b285');
INSERT INTO `knowledge_point_compose_problem` VALUES ('cc2946fd91354083bb55b9f225aa18cb', '2017-04-25 08:43:55', '2017-04-25 08:43:55', null, '451cf400e6984a209c027202e347de67', '8c8b1f12503c47ab8690e499e3b2e3a1');
INSERT INTO `knowledge_point_compose_problem` VALUES ('ebab9e02a3484ef18e8f1f491ad24f1a', '2017-04-14 16:22:23', '2017-04-14 16:22:23', null, '71650d18ebc647678f85e16d2a136b26', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('f39e33e6839b479cb95271cff6bfeb04', '2017-04-14 16:22:43', '2017-04-14 16:22:43', null, '3c67d28dcd4842d4b75a47919b830ead', '7bdfed3a1e6c4234a8085b9229db8a8d');
INSERT INTO `knowledge_point_compose_problem` VALUES ('f3be8b84eee84527bb8d0a33e544515d', '2017-04-28 09:48:51', '2017-04-28 09:48:51', null, '2fc8dc03576d4d8da2679f84b558587e', '9c976a30f629427fa7b718c1c9a9ec9a');

-- ----------------------------
-- Table structure for problem
-- ----------------------------
DROP TABLE IF EXISTS `problem`;
CREATE TABLE `problem` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `content` varchar(500) NOT NULL COMMENT '试题内容',
  `uk_problem_type_id` char(32) DEFAULT NULL COMMENT '试题类型ID——onUpdate=casade;onDelete=set null',
  PRIMARY KEY (`id`),
  KEY `uk_problem_type_id` (`uk_problem_type_id`),
  CONSTRAINT `problem_ibfk_1` FOREIGN KEY (`uk_problem_type_id`) REFERENCES `problem_type` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='试题';

-- ----------------------------
-- Records of problem
-- ----------------------------
INSERT INTO `problem` VALUES ('2f93e81ff01e428187cc48befc8d4993', '2017-04-26 09:43:27', '2017-04-26 09:43:27', '', '题目：判断101-200之间有多少个素数，并输出所有素数。\n\n程序分析：判断素数的方法：用一个数分别去除2到sqrt(这个数)，如果能被整除，则表明此数不是素数，反之是素数。', '7b473fbe98fb4b0eb19dccb7e9871cda');
INSERT INTO `problem` VALUES ('2fc8dc03576d4d8da2679f84b558587e', '2017-04-28 09:56:46', '2017-04-28 09:56:43', '', '题目：将一个正整数分解质因数。例如：输入90,打印出90=2*3*3*5。\n\n程序分析：对n进行分解质因数，应先找到一个最小的质数k，然后按下述步骤完成：\n\n(1)如果这个质数恰等于n，则说明分解质因数的过程已经结束，打印出即可。\n\n(2)如果n<>k，但n能被k整除，则应打印出k的值，并用n除以k的商,作为新的正整数n,重复执行第一步。\n\n(3)如果n不能被k整除，则用k+1作为k的值,重复执行第一步。', '3');
INSERT INTO `problem` VALUES ('3c67d28dcd4842d4b75a47919b830ead', '2017-04-26 09:43:33', '2017-04-26 09:43:33', '', '题目：打印出所有的\"水仙花数\"，所谓\"水仙花数\"是指一个三位数，其各位数字立方和等于该数本身。例如：153是一个\"水仙花数\"，因为153=1的三次方＋5的三次方＋3的三次方。\n\n程序分析：利用for循环控制100-999个数，每个数分解出个位，十位，百位。', '7b473fbe98fb4b0eb19dccb7e9871cda');
INSERT INTO `problem` VALUES ('451cf400e6984a209c027202e347de67', '2017-04-26 09:43:36', '2017-04-26 09:43:36', '', '题目：求s=a+aa+aaa+aaaa+aa...a的值，其中a是一个数字。例如2+22+222+2222+22222(此时共有5个数相加)，几个数相加有键盘控制。\n\n程序分析：关键是计算出每一项的值。', '7b473fbe98fb4b0eb19dccb7e9871cda');
INSERT INTO `problem` VALUES ('4f12aeefd4fe4ff6801d88271e7f1c23', '2017-04-14 16:23:16', '2017-04-14 16:23:16', '', '题目：输入一行字符，分别统计出其中英文字母、空格、数字和其它字符的个数。\n\n程序分析：利用while语句,条件为输入的字符不为\'\\n\'.', null);
INSERT INTO `problem` VALUES ('5b14a88381e84fa1a21ae4d3e6897be2', '2017-04-14 16:23:36', '2017-04-14 16:23:36', '', '题目：一个数如果恰好等于它的因子之和，这个数就称为\"完数\"。例如6=1＋2＋3.编程找出1000以内的所有完数。', null);
INSERT INTO `problem` VALUES ('71650d18ebc647678f85e16d2a136b26', '2017-04-14 16:22:23', '2017-04-14 16:22:23', '', '古典问题：有一对兔子，从出生后第3个月起每个月都生一对兔子，小兔子长到第三个月后每个月又生一对兔子，假如兔子都不死，问每个月的兔子对数为多少？\n\n程序分析： 兔子的规律为数列1,1,2,3,5,8,13,21....', null);
INSERT INTO `problem` VALUES ('be6d73a26f164459a3e2933f17646bd4', '2017-04-14 16:23:08', '2017-04-14 16:23:08', '', '题目：输入两个正整数m和n，求其最大公约数和最小公倍数。\n\n程序分析：利用辗除法。', null);
INSERT INTO `problem` VALUES ('f874aedfee0a4e7283dc35db097d5845', '2017-04-23 17:33:18', '2017-04-23 17:33:17', '专门的测试试题专门的测试试题专门的测试试题专门的测试试题\n', '专门的测试试题专门的测试试题专门的测试试题专门的测试试题', '7b473fbe98fb4b0eb19dccb7e9871cda');

-- ----------------------------
-- Table structure for problem_answer
-- ----------------------------
DROP TABLE IF EXISTS `problem_answer`;
CREATE TABLE `problem_answer` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_problem_id` char(32) NOT NULL COMMENT '对应试题ID——onUpdate=casade;onDelete=casade',
  `content` varchar(500) NOT NULL COMMENT '答案/试题解析内容',
  `source` varchar(50) DEFAULT NULL COMMENT '答案来源',
  PRIMARY KEY (`id`),
  KEY `uk_problem_id` (`uk_problem_id`),
  CONSTRAINT `problem_answer_ibfk_1` FOREIGN KEY (`uk_problem_id`) REFERENCES `problem` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='试题解析/答案';

-- ----------------------------
-- Records of problem_answer
-- ----------------------------
INSERT INTO `problem_answer` VALUES ('acd999473e404637a340ab6dde488914', '2017-04-26 10:17:25', '2017-04-26 10:17:25', '未尽事项', '2fc8dc03576d4d8da2679f84b558587e', '试题解析', '解析来源');

-- ----------------------------
-- Table structure for problem_compose_examination_papers
-- ----------------------------
DROP TABLE IF EXISTS `problem_compose_examination_papers`;
CREATE TABLE `problem_compose_examination_papers` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_problem_id` char(32) NOT NULL COMMENT '试题ID(*）onUpdate=casade;onDelete=casade',
  `uk_examination_papers_id` char(32) DEFAULT NULL COMMENT '试卷ID(*)onUpdate=casade;onDelete=casade\r\n\r\n因为时间的关系不能再强制关联试卷了。',
  PRIMARY KEY (`id`),
  KEY `uk_problem_id` (`uk_problem_id`),
  KEY `problem_compose_examination_papers_ibfk_2` (`uk_examination_papers_id`),
  CONSTRAINT `problem_compose_examination_papers_ibfk_1` FOREIGN KEY (`uk_problem_id`) REFERENCES `problem` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `problem_compose_examination_papers_ibfk_2` FOREIGN KEY (`uk_examination_papers_id`) REFERENCES `examination_papers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='试题组成试卷';

-- ----------------------------
-- Records of problem_compose_examination_papers
-- ----------------------------

-- ----------------------------
-- Table structure for problem_type
-- ----------------------------
DROP TABLE IF EXISTS `problem_type`;
CREATE TABLE `problem_type` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(64) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='试题类型';

-- ----------------------------
-- Records of problem_type
-- ----------------------------
INSERT INTO `problem_type` VALUES ('1', '2017-04-14 13:56:48', '2017-04-14 13:56:48', '选择题', '选择题');
INSERT INTO `problem_type` VALUES ('2', '2017-04-14 14:01:09', '2017-04-14 14:01:09', '填空题', '填空题');
INSERT INTO `problem_type` VALUES ('3', '2017-04-14 09:41:46', '2017-04-14 09:41:48', null, '解答题');
INSERT INTO `problem_type` VALUES ('7b473fbe98fb4b0eb19dccb7e9871cda', '2017-04-14 13:54:27', '2017-04-14 13:54:27', '简答题', '简答题');

-- ----------------------------
-- Table structure for teacher
-- ----------------------------
DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(32) NOT NULL,
  `office` varchar(40) DEFAULT NULL,
  `contact` char(100) DEFAULT NULL COMMENT '联系方式',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='教师\r\n';

-- ----------------------------
-- Records of teacher
-- ----------------------------
INSERT INTO `teacher` VALUES ('402be4b8964d4c8fbb2c6f080c4b9043', '2017-04-27 15:44:07', '2017-04-27 15:44:07', '梁实秋，原名梁治华，字实秋，1903年1月6日出生于北京，浙江杭县（今杭州）人。笔名子佳、秋郎、程淑等。中国著名的散文家、学者、文学批评家、翻译家，国内第一个研究莎士比亚的权威，曾与鲁迅等左翼作家笔战不断。', '梁秋实', '', '15133350722');
INSERT INTO `teacher` VALUES ('54272c17ca6244aeba59b5692a50517a', '2017-04-13 08:56:10', '2017-04-13 08:56:10', '一个正直，极富经验，且不修边幅的人民教师', '孙皓晖', '', '15133350722');
INSERT INTO `teacher` VALUES ('72911a58ba7d4fa099bed8dd10c4163a', '2017-04-13 08:53:03', '2017-04-13 08:53:03', '一个风趣幽默的但是很有深度的教师', '王小波', '', '15133350722');
INSERT INTO `teacher` VALUES ('b324139055604a00ada73be667019418', '2017-04-13 08:48:35', '2017-04-13 08:48:35', '一个负责的好老师', 'Java教师', '', '15133350722');

-- ----------------------------
-- Table structure for teacher_teach_course
-- ----------------------------
DROP TABLE IF EXISTS `teacher_teach_course`;
CREATE TABLE `teacher_teach_course` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_teacher_id` char(32) NOT NULL COMMENT '教师ID(*）——onUpdate=casade;onDelete=casade',
  `uk_course_id` char(32) NOT NULL COMMENT '课程ID(*)——onUpdate=casade;onDelete=casade',
  PRIMARY KEY (`id`),
  KEY `uk_teacher_id` (`uk_teacher_id`),
  KEY `teacher_teach_course_ibfk_2` (`uk_course_id`),
  CONSTRAINT `teacher_teach_course_ibfk_1` FOREIGN KEY (`uk_teacher_id`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `teacher_teach_course_ibfk_2` FOREIGN KEY (`uk_course_id`) REFERENCES `course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='教师讲授课程';

-- ----------------------------
-- Records of teacher_teach_course
-- ----------------------------
INSERT INTO `teacher_teach_course` VALUES ('3e0d068f48fb484386efeb802ab1271d', '2017-04-13 08:48:36', '2017-04-13 08:48:36', null, 'b324139055604a00ada73be667019418', '39ba892ec130424e9bdb7717f471850d');
INSERT INTO `teacher_teach_course` VALUES ('7dcbbf4565eb48fbb263dc4ccc7e8962', '2017-04-13 08:53:05', '2017-04-13 08:53:05', null, '72911a58ba7d4fa099bed8dd10c4163a', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `teacher_teach_course` VALUES ('8ee51165fb774f8397ce0f39571f6459', '2017-04-27 15:44:09', '2017-04-27 15:44:09', null, '402be4b8964d4c8fbb2c6f080c4b9043', 'fefb72d354a34367aa083e39b20c6d55');
INSERT INTO `teacher_teach_course` VALUES ('8fafae6f3fe247c59139c4a306f07584', '2017-04-13 08:56:12', '2017-04-13 08:56:12', null, '54272c17ca6244aeba59b5692a50517a', '492314f001a746779246f99778d68155');

-- ----------------------------
-- Table structure for textbook
-- ----------------------------
DROP TABLE IF EXISTS `textbook`;
CREATE TABLE `textbook` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `name` varchar(100) NOT NULL COMMENT '书名',
  `uk_isbn` char(13) NOT NULL COMMENT 'ISBN(*)',
  `press` varchar(50) DEFAULT NULL COMMENT '出版社',
  `edition` varchar(32) DEFAULT NULL COMMENT '版本',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='教材';

-- ----------------------------
-- Records of textbook
-- ----------------------------
INSERT INTO `textbook` VALUES ('5bbccb75df2c4594b3aab8b353bfb47c', '2017-04-13 08:54:28', '2017-04-13 08:54:28', '《计算机组成原理》讲述了计算机的一般原理，并注意到与实际应用相结合。全书内容由浅入深，每章之后均附有习题，便于自学。', '计算机组成原理', '1029384756219', '清华大学出版社', '第五版');
INSERT INTO `textbook` VALUES ('887d712ba1764f6e8e2fbcf384971e20', '2017-04-13 08:50:51', '2017-04-13 08:50:51', '这本书是系列书籍，作者李刚，还有诸如Android疯狂讲义等的系列入门书籍，很受读者欢迎', 'Java疯狂讲义', '1029384756219', '工业出版社', '第三版');
INSERT INTO `textbook` VALUES ('c6e4ec85202845e8a30ab25afd166509', '2017-04-13 08:57:20', '2017-04-13 08:57:20', '《计算机组成及汇编语言原理》以Java虚拟机为基础介绍计算机组织和系统结构。', '计算机组成及汇编语言原理', '1029384756219', '机械工业出版社', '');
INSERT INTO `textbook` VALUES ('d8fffc632ecf4b9793f2d9c86ffb1119', '2017-04-27 15:45:35', '2017-04-27 15:45:35', '《沉思录》是公元2世纪后期古代罗马皇帝马可·奥勒留传下来的一部个人哲学思考录，主要思考人生伦理问题，兼及自然哲学；是奥勒留所作的一本写给自己的思想散文集。这本与自己的十二卷对话，内容大部分是他在鞍马劳顿中所写，是斯多葛派哲学（斯多亚哲学）的一个里程碑。', '沉思录', '1029384756219', '清华大学出版社', '第五版');

-- ----------------------------
-- Table structure for textbook_belong_course
-- ----------------------------
DROP TABLE IF EXISTS `textbook_belong_course`;
CREATE TABLE `textbook_belong_course` (
  `id` char(32) NOT NULL COMMENT 'ID',
  `utc8_create` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间-当前的机器时间',
  `utc8_modify` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间-当前的机器时间',
  `other` varchar(255) DEFAULT NULL,
  `uk_textbook_id` char(32) NOT NULL COMMENT '教材ID(*）onUpdate=casade;onDelete=casade',
  `uk_course_id` char(32) NOT NULL COMMENT '课程ID(*)onUpdate=casade;onDelete=casade',
  PRIMARY KEY (`id`),
  KEY `uk_textbook_id` (`uk_textbook_id`),
  KEY `textbook_belong_course_ibfk_2` (`uk_course_id`),
  CONSTRAINT `textbook_belong_course_ibfk_1` FOREIGN KEY (`uk_textbook_id`) REFERENCES `textbook` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `textbook_belong_course_ibfk_2` FOREIGN KEY (`uk_course_id`) REFERENCES `course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='教材属于课程';

-- ----------------------------
-- Records of textbook_belong_course
-- ----------------------------
INSERT INTO `textbook_belong_course` VALUES ('4a09c8d8409048689540917e354506be', '2017-04-27 15:45:37', '2017-04-27 15:45:37', null, 'd8fffc632ecf4b9793f2d9c86ffb1119', 'fefb72d354a34367aa083e39b20c6d55');
INSERT INTO `textbook_belong_course` VALUES ('8969380a7a084081be326cb5fb60059f', '2017-04-13 08:50:54', '2017-04-13 08:50:54', null, '887d712ba1764f6e8e2fbcf384971e20', '39ba892ec130424e9bdb7717f471850d');
INSERT INTO `textbook_belong_course` VALUES ('b7980d4d41a14e208679bc7571a26b11', '2017-04-13 08:54:29', '2017-04-13 08:54:29', null, '5bbccb75df2c4594b3aab8b353bfb47c', '0fe5207c6dcf4a2a93e2af00baa7263b');
INSERT INTO `textbook_belong_course` VALUES ('e451b6708ea8467e8ce3e4484bb0cfe1', '2017-04-13 08:57:22', '2017-04-13 08:57:22', null, 'c6e4ec85202845e8a30ab25afd166509', '492314f001a746779246f99778d68155');
