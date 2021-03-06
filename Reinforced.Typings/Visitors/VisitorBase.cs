﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reinforced.Typings.Ast;

namespace Reinforced.Typings.Visitors
{
    abstract class VisitorBase : IRtVisitor
    {
        public void Visit(RtNode node)
        {
            if (node == null) return;
            if (node is RtField) { Visit((RtField)node); return; }
            if (node is RtInterface) { Visit((RtInterface)node); return; }
            if (node is RtFuncion) { Visit((RtFuncion)node); return; }
            if (node is RtArgument) { Visit((RtArgument)node); return; }
            if (node is RtClass) { Visit((RtClass)node); return; }
            if (node is RtIdentifier) { Visit((RtIdentifier)node); return; }
            if (node is RtDelegateType) { Visit((RtDelegateType)node); return; }
            if (node is RtSimpleTypeName) { Visit((RtSimpleTypeName)node); return; }
            if (node is RtRaw) { Visit((RtRaw)node); return; }
            if (node is RtJsdocNode) { Visit((RtJsdocNode)node); return; }
            if (node is RtModule) { Visit((RtModule)node); return; }
            if (node is RtEnumValue) { Visit((RtEnumValue)node); return; }
            if (node is RtEnum) { Visit((RtEnum)node); return; }
            if (node is RtDictionaryType) { Visit((RtDictionaryType)node); return; }
            if (node is RtArrayType) { Visit((RtArrayType)node); return; }
            if (node is RtConstructor) { Visit((RtConstructor)node); return; }

            throw new Exception("Unknown node passed");
        }

        public abstract void Visit(RtField node);
        public abstract void Visit(RtInterface node);
        public abstract void Visit(RtFuncion node);
        public abstract void Visit(RtArgument node);
        public abstract void Visit(RtClass node);
        public abstract void Visit(RtIdentifier node);
        public abstract void Visit(RtDelegateType node);
        public abstract void Visit(RtSimpleTypeName node);
        public abstract void Visit(RtRaw node);
        public abstract void Visit(RtJsdocNode node);
        public abstract void Visit(RtModule node);
        public abstract void Visit(RtEnumValue node);
        public abstract void Visit(RtEnum node);
        public abstract void Visit(RtDictionaryType node);
        public abstract void Visit(RtArrayType node);
        public abstract void Visit(RtConstructor node);
    }
}
