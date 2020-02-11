using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract string Display(int depth);
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public void Add(Component component)
        {
            children.Add(component);
        }

        public void Remove(Component component)
        {
            children.Remove(component);
        }

        public override string Display(int depth)
        {
            string s = new String('-', depth) + name + "\n";

            foreach (Component component in children)
            {
                s+=component.Display(depth + 1);
            }
            return s;
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override string Display(int depth)
        {
            return new String('-', depth) + name + "\n";
        }
    }
    public class Panel : Composite
    {
        public Panel(string name) : base(name)
        {
            base.name.Insert(0, "Панель ");
        }
    }
    public class Button : Leaf
    {
        public Button(string name) : base(name)
        {
            base.name.Insert(0, "Кнопка ");
        }
    }
    public class InputText : Leaf
    {
        public InputText(string name) : base(name)
        {
            base.name.Insert(0, "Поле ввода ");
        }
    }
}
