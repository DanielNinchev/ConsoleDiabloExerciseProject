using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class SkillTree<T>
    {
        // The root of the SkillTree
        private Skill<T> root;

        /// <summary> Constructs the SkillTree </summary>
        /// <param name="skillName">the value of the node</param>
        public SkillTree(T skillName)
        {
            if (skillName == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new Skill<T>(skillName);
        }

        /// <summary> Constructs the SkillTree </summary>
        /// <param name="skillName">the name of the skill</param>
        /// <param name="children">the children (derivative skills) of the root</param>
        public SkillTree(T skillName, params SkillTree<T>[] children) : this(skillName)
        {
            foreach (SkillTree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary> Traverses and prints SkillTree in Depth First Search (DFS) order </summary>
        /// <param name="root">the root of the SkillTree to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        private void PrintDFS(Skill<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.SkillName);

            Skill<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary> Traverses & prints the SkillTree in Depth First Search (DFS) order </summary>
        public void PrintDFS() => this.PrintDFS(this.root, string.Empty);
    }
}

