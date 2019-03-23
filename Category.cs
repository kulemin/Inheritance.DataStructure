using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category : IComparable
    {
        String product;
        MessageType type;
        MessageTopic topic;
        public Category(String product, MessageType type, MessageTopic topic)
        {
            this.product = product;
            this.type = type;
            this.topic = topic;
        }

        public override bool Equals(object obj)
        {
            return obj is Category
                && (obj as Category).product == product
                && (obj as Category).type == type
                && (obj as Category).topic == topic;
        }

        public override string ToString()
        {
            return product + "." + type + "." + topic;
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return -1;
            else if ((obj as Category).product == null) return -1;
            else if ((obj as Category).product.CompareTo(product) == -1) return 1;
            else if ((obj as Category).product.CompareTo(product) == 1) return -1;
            else if ((obj as Category).type.CompareTo(type) == -1) return 1;
            else if ((obj as Category).type.CompareTo(type) == 1) return -1;
            else if ((obj as Category).topic.CompareTo(topic) == -1) return 1;
            else if ((obj as Category).topic.CompareTo(topic) == 1) return -1;
            else return 0;
        }

        public static bool operator ==(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) == 0;
        }

        public static bool operator !=(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) != 0;
        }

        public static bool operator <(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) == -1;
        }

        public static bool operator >(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) == 1;
        }

        public static bool operator <=(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) == -1 || catFirst.CompareTo(catSecond) == 0;
        }

        public static bool operator >=(Category catFirst, Category catSecond)
        {
            return catFirst.CompareTo(catSecond) == 1 || catFirst.CompareTo(catSecond) == 0;
        }
    }
}
