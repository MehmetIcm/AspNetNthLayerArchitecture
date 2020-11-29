using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Logging
{
    // IL Weaving : PostSharp package'ını kullnarak UI'da ya da başka bir yerde çağırdığımız methodun önüne arkasına vs yeni bir method eklememizi sağlar
    // Method Interception : UI'ya gidip çalıştırmak istediğimiz Method'un üzerine [LogAspect] yazdığımız zaman methodun başında bu kodu çalıştır deriz
    [Serializable]
    public class LogAspect
    {
        public LogAspect()
        {
            Console.WriteLine("Logged");
        }
    }
}
