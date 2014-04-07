using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyApi
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DocumentationAttribute : Attribute
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationAttribute" /> class.
        /// </summary>
        /// <param name="text"></param>
        public DocumentationAttribute(string text)
		{
            if (text == null) throw new ArgumentNullException("text");
			this.Text = text;
		}

        /// <summary>
        /// The documentation text
        /// </summary>
        public string Text { get; set; }
    }
}
