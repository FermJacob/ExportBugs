//-----------------------------------------------------
// <copyright file="Fields.cs" company="Magenic Technologies">
//  Copyright 2014 Magenic Technologies, All rights Reserved
// </copyright>
// <summary>Object to store field data</summary>
//-----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBugs.Models
{
    /// <summary>
    /// Class Field
    /// </summary>
    public class Fields
    {
        /// <summary>
        /// Initializes a new instance of the Fields class
        /// </summary>
        /// <param name="name">String of the name</param>
        public Fields(string name)
        {
            this.FieldName = name;
        }

        /// <summary>
        /// Gets the string to hold field name
        /// </summary>
        public string FieldName { get; private set; }
    }
}
