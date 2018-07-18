using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{

    public abstract class LogFactory
    {
        public  abstract  Log createLog();
     //   public abstract void crateNull();
    }

    public abstract class Log
    {
        public abstract void writeLog();
    }

    public class FileLogFactory : LogFactory
    {
        public override Log createLog()
        {
            return new FileLog();
        }
    }

    public class FileLog : Log
    {
        public override void writeLog()
        {
            Console.WriteLine("文件记录日志");
        }
    }

    public class DatabaseLogFactory : LogFactory
    {
        public override Log createLog()
        {
            return new DatabaseLog();
        }
    }

    public class DatabaseLog : Log
    {
        public override void writeLog()
        {
            Console.WriteLine("数据库记录日志");
        }
    }


}
