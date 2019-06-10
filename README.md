# c-hw2
c#hw2
##新建俩个类，一个static一个非static
```
static class staticClass
    {
        public static int SC(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine(args[1] + args[2]);
            }
            return 0;

        }
    }
```
***
```
class noneStatic
    {
        public int NSC(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine(args[1] + args[3]);
            }
            return 0;
        }
    }
```
***
##设置命令行参数，成功则c#不挂
![1](https://github.com/luckyxiaohei/img/blob/master/2.1.png)
***
##main里面分别调用俩类的方法，实例化非static，static无需实例化之间类名调用
![2](https://github.com/luckyxiaohei/img/blob/master/2.2.png)
***
##调试结果
![3](https://github.com/luckyxiaohei/img/blob/master/2.3.png)
***
***
***
##创建wpf项目，添加俩个文本框，其中一个只读，利用textchange事件实现俩文本框内容同步
![1](https://github.com/luckyxiaohei/img/blob/master/2.4.png)
![2](https://github.com/luckyxiaohei/img/blob/master/2.5.png)

***
##添加命令行参数，使用Environment.GetCommandLineArgs()获取，因为第一个获取的是当前程序全路径，因此args[0]要被忽略，这里选择了第二个参数也就是args[2]
***
![3](https://github.com/luckyxiaohei/img/blob/master/2.6.png)
***
##点击button输出参数
![4](https://github.com/luckyxiaohei/img/blob/master/2.7.png)
***
***





