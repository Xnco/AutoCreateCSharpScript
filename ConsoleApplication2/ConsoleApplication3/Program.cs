using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;


namespace ConsoleApplication3
{

    public struct MemberInfo
    {
        public string mType;
        public string mName;

        public MemberInfo(string type, string name)
        {
            mType = type;
            mName = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<MemberInfo> all = new List<MemberInfo>();
            all.Add(new MemberInfo("int", "charid"));

            Create("One.cs", 55, all);
        }

        static void Create(string scriptName, short id,  List<MemberInfo> allMember)
        {
            // 编译器单元 - 一个文件就是一个编辑器单元
            CodeCompileUnit unit = new CodeCompileUnit();

            // 命名空间 - 
            CodeNamespace ns = new CodeNamespace();

            // Add -> 引用必要的命名空间
            ns.Imports.Add(new CodeNamespaceImport("System"));

            // 定义一个类 - 类名
            CodeTypeDeclaration needClass = new CodeTypeDeclaration("TestClass");
            needClass.IsClass = true;
            needClass.TypeAttributes = TypeAttributes.Public;
            needClass.BaseTypes.Add("PackageBase");  // 类的继承

            // 把类放到该该命名空间下
            ns.Types.Add(needClass);
            // 把命名空间放在编辑器单元中
            unit.Namespaces.Add(ns);

            // 创建 ID 字段
            CodeMemberField field_id = new CodeMemberField(typeof(short), "ID");
            field_id.Attributes = MemberAttributes.Public;
            field_id.InitExpression = new CodePrimitiveExpression(id);
            needClass.Members.Add(field_id);

            // 创建n个字段
            foreach (var item in allMember)
            {
                CodeMemberField field = new CodeMemberField(item.mType, item.mName);
                field.Attributes = MemberAttributes.Public;

                needClass.Members.Add(field);
            }

            //添加方法， 
            CodeMemberMethod mothod = new CodeMemberMethod();
            // 方法 override
            mothod.Attributes = MemberAttributes.Override | MemberAttributes.Public;
            mothod.Name = "Create";
            mothod.ReturnType = new CodeTypeReference(typeof(byte[]));
            // 添加方法中的语句
            //mothod.Statements.Add();

            // 生成脚本
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeGeneratorOptions option = new CodeGeneratorOptions(); // 成员间有空格
            option.BracingStyle = "C";  // C 风格脚本
            option.BlankLinesBetweenMembers = true;  // 成员之间插入空行

            string outputFile = "F:\\TestF\\TestClass.cs"; // 脚本文件名
            StreamWriter sw = new StreamWriter(outputFile);

            provider.GenerateCodeFromCompileUnit(unit, sw, option);  // 将编辑器中的命名空间和类都写入具体的文件中
            sw.Close();
        }
    }
}
