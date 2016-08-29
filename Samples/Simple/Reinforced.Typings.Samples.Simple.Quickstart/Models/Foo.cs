using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reinforced.Typings.Samples.Simple.Quickstart.Models {
    /// <summary>
    /// 測試用 Model
    /// </summary>
    [TsInterface]
    public class Foo {

        /// <summary>
        /// Age
        /// </summary>
        [Range(1, 100)]
        public int Age { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        ///// <summary>
        ///// Test Method
        ///// </summary>
        //public void Test() { }
    }
}