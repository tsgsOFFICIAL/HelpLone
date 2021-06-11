using System;

namespace HelpLone
{
    class Program
    {
        static void Main()
        {

            Console.ReadKey(true);
        }
    }
    /// <summary>
    /// Common character traits
    /// </summary>
    public interface ICharacter
    {
        /// <summary>
        /// Everybody can heal them self
        /// </summary>
        void Heal();
        /// <summary>
        /// Everyone can die
        /// </summary>
        void Die();
        /// <summary>
        /// Everyone fights
        /// </summary>
        void Fight();
    }
    /// <summary>
    /// Throw stuff
    /// </summary>
    public interface IThrow
    {
        /// <summary>
        /// Wizard Only
        /// </summary>
        void ThrowMagicMisile();
        /// <summary>
        /// Wizard only
        /// </summary>
        void ThrowFrostNova();
    }
    /// <summary>
    /// Teleport
    /// </summary>
    public interface ITeleport
    {
        /// <summary>
        /// Wizard & Witch only
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        void Teleport(int x, int y);
    }
    /// <summary>
    /// Shield
    /// </summary>
    public interface IShield
    {
        /// <summary>
        /// Witch & Knight only
        /// </summary>
        void ShieldGlare();
        /// <summary>
        /// Witch & Knight only
        /// </summary>
        void RaiseShield();
    }
    /// <summary>
    /// Fight
    /// </summary>
    public interface IFight
    {
        /// <summary>
        /// Barbarian & Knight only
        /// </summary>
        void Bash();
        /// <summary>
        /// Barbarian & Knight only
        /// </summary>
        void Cleave();
        /// <summary>
        /// Barbarian & Knight only
        /// </summary>
        void Slash();
    }
    /// <summary>
    /// Wizard
    /// </summary>
    public class Wizard : ICharacter, IThrow, ITeleport
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }
        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
    /// <summary>
    /// Barbarian
    /// </summary>
    public class Babarian : ICharacter, IFight
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }
        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
    /// <summary>
    /// Knight
    /// </summary>
    public class Knight : ICharacter, IFight, IShield
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }
        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
    /// <summary>
    /// Witch
    /// </summary>
    public class Witch : ICharacter, ITeleport, IShield
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
