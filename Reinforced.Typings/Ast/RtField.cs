﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reinforced.Typings.Ast
{
    /// <summary>
    /// AST node for TypeScript field
    /// </summary>
    public class RtField : RtMember
    {
        /// <summary>
        /// Field name
        /// </summary>
        public RtIdentifier Identifier { get; set; }

        /// <summary>
        /// Field type
        /// </summary>
        public RtTypeName Type { get; set; }

        /// <summary>
        /// TypeScript expression to initialize field
        /// </summary>
        public string InitializationExpression { get; set; }

        /// <summary>
        /// Child nodes
        /// </summary>
        public override IEnumerable<RtNode> Children
        {
            get
            {
                yield return Documentation;
                yield return Identifier;
                yield return Type;
            }
        }

        public Dictionary<string, RtField[]> Attributes { get; set; }

        /// <summary>
        /// Visitor acceptance
        /// </summary>
        /// <param name="visitor">Visitor</param>
        public override void Accept(IRtVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// Typed visitor acceptance
        /// </summary>
        /// <param name="visitor">Visitor</param>
        public override void Accept<T>(IRtVisitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
