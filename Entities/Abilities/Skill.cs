using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class Skill<T>
    {
        //Contains the value of the node
        private T skill;

        //Shows whether the current node has parent
        private bool hasParent;

        //Contains the children of the node
        private List<Skill<T>> children;

        /// <summary> Constructs a tree node </summary>
        /// <param name="skill">the value of the node</param>
        public Skill(T skill)
        {
            if (skill == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.skill = skill;
            this.children = new List<Skill<T>>();
        }

        /// <summary> The value of the node </summary>
        public T SkillName
        {
            get => this.skill;
            set => this.skill = value;
        }

        public bool HasParent
        {
            get => this.hasParent;
        }

        /// <summary> The number of node's children </summary>
        public int ChildrenCount => this.children.Count;

        /// <summary> Adds child to the node </summary>
        /// <param name="child">the child to be added</param>
        public void AddChild(Skill<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary> Gets the child of the node at given index </summary>
        /// <param name="index">the index of the desired child</param>
        /// <returns>the child on the given position</returns>
        public Skill<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
