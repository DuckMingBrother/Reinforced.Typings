﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Reinforced.Typings.Attributes;
using Reinforced.Typings.Fluent.Interfaces;

namespace Reinforced.Typings.Fluent
{
    /// <summary>
    ///     Configuration builder for Enum type
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public class EnumConfigurationBuilder<TEnum> : IEnumConfigurationBuidler
        where TEnum : struct
    {
        private readonly ICollection<TsAddTypeReferenceAttribute> _references = new List<TsAddTypeReferenceAttribute>();

        private readonly Dictionary<FieldInfo, EnumValueExportConfiguration> _valueExportConfigurations =
            new Dictionary<FieldInfo, EnumValueExportConfiguration>();

        internal EnumConfigurationBuilder()
        {
            AttributePrototype = new TsEnumAttribute();
        }

        private TsEnumAttribute AttributePrototype { get; set; }

        Dictionary<FieldInfo, EnumValueExportConfiguration> IEnumConfigurationBuidler.ValueExportConfigurations
        {
            get { return _valueExportConfigurations; }
        }

        TsEnumAttribute IExportConfiguration<TsEnumAttribute>.AttributePrototype
        {
            get { return AttributePrototype; }
        }

        Type IEnumConfigurationBuidler.EnumType
        {
            get { return typeof (TEnum); }
        }

        ICollection<TsAddTypeReferenceAttribute> IReferenceConfigurationBuilder.References
        {
            get { return _references; }
        }

        string IReferenceConfigurationBuilder.PathToFile { get; set; }
    }
}