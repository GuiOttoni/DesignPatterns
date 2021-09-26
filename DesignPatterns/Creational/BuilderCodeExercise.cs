using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public class BuilderCodeExercise
    {
        internal class CodeBuilder
        {
            ClassElement rootClass;
            public CodeBuilder(string className)
            {
                this.rootClass = new ClassElement();
                this.rootClass.Name = className;
            }
            public CodeBuilder AddField(string fieldName, string fieldType)
            {
                var e = new ClassElement(fieldName, fieldType);
                rootClass.Fields.Add(e);
                return this;
            }
            public override string ToString()
            {
                return rootClass.ToString();
            }
        }

        internal class ClassElement
        {
            public string Name, Type;
            public List<ClassElement> Fields = new List<ClassElement>();
            private const int indentSize = 2;

            public ClassElement()
            {

            }

            public ClassElement(string name, string type)
            {
                Name = name;
                Type = type;
            }

            private string ToStringImpl(int indent)
            {
                var sb = new StringBuilder();
                var i = new string(' ', indentSize * indent);

                sb.Append($"{i}public class {Name}\n " + '{' + "\n");

                foreach (var e in Fields)
                {
                    sb.Append(new string(' ', indentSize * (indent + 1)));
                    sb.Append($"public {e.Type} {e.Name};");
                    sb.Append("\n");
                }



                sb.Append($"{i} " + '}' + "\n");
                return sb.ToString();
            }

            public override string ToString()
            {
                return ToStringImpl(0);
            }
        }
    }
}
