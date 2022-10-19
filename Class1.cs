using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollments
{
   public class StubExtensionManager : IExtensionNanager  
    {  
        public bool CheckExtension(string FileName)  
        {  
            return true;  
        }  
    }  
  
    public class FileChecker  
    {  
        IExtensionManager objmanager = null;  
        //Default constructor  
        public FileChecker()  
        {  
            objmanager = new ExtensionManager();  
        }  
        //parameterized constructor  
        public FileChecker(IExtensionNanager tmpManager)  
        {  
            objmanager = tmpManager;  
        }  
  
        public Boolean CheckFile(String FileName)  
        {  
            return objmanager.CheckExtension(FileName);  
        }  
    }

   
} 

