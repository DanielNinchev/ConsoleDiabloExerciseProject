using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.Factory
{
    public class BarbarianSkillTreeFactory
    {
        static void InitializeBarbSkillTree()
        {
            SkillTree<string> barbarianSkills =
                new SkillTree<string>("Warcries",
                    new SkillTree<string>("Howl",
                        new SkillTree<string>("Taunt",
                            new SkillTree<string>("Battle Cry",
                                new SkillTree<string>("War Cry")))),
                        new SkillTree<string>("Shout",
                            new SkillTree<string>("Battle Orders",
                                new SkillTree<string>("Battle Command"))),
                    new SkillTree<string>("Find Potion",
                        new SkillTree<string>("Find Item",
                            new SkillTree<string>("Grim Ward"))),
                new SkillTree<string>("Combat Masteries",
                    new SkillTree<string>("Sword Mastery"),
                    new SkillTree<string>("Axe Mastery"),
                    new SkillTree<string>("Flail Mastery"),
                    new SkillTree<string>("Mace Mastery"),
                    new SkillTree<string>("Iron Skin",
                        new SkillTree<string>("Natural Resistance")))
                );


        }
    }
}
