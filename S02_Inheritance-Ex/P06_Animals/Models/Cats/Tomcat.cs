﻿namespace Animals.Models.Cats
{
    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";
        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {
        }
        public override string ProduceSound() => "MEOW";
    }
}
