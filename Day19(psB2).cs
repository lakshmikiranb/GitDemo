using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{

    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DeveloperAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public DeveloperAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            throw new NotImplementedException();
        }

        public string StereoDisc
        {
            get { return StereoDisc; }
        }

        // This is a named argument
        public string songname { get; set; }
        public string language { get; set; }
        public string lyrics { get; set; }



    }
}
