using System;
using System.Reflection;
using NUnit.Framework;

namespace TryNUnitDotNet
{
    [TestFixture]
    public class MainTest
    {
        // Program class has `internal` accessibility by default
        // FriendlyMainClaim() is `private` by default
        // FriendlyMainClaim() must be `internal` or `public` to test here
        [Test]
        public void FriendlyMainClaimReturnsString()
        {
            string text = Program.FriendlyMainClaim();
            Assert.That(text, Is.TypeOf(typeof(string)));
        }

        // Check that static method is private
        [Test]
        public void PrivateExclamationIsPrivate()
        {
            Type t = typeof(Program);
            MethodInfo mInfo = t.GetMethod("PrivateFriendlyMainClaim",
                BindingFlags.NonPublic | BindingFlags.Static);
            Assert.That(mInfo.IsPrivate);
        }

        // PrivateFriendlyMainClaim() is `private` by default
        // We can't run this code because we cannot access a private method
        //[Test]
        //public void PrivateFriendlyMainClaimReturnsString()
        //{
        //    MainClass obj = new Program();
        //    string text = obj.PrivateFriendlyMainClaim();
        //    Assert.That(text, Is.TypeOf(typeof(string)));
        //}

    }

    [TestFixture]
    public class StomachTest
    {
        // Check class inheritance
        [Test]
        public void StomachInheritsObjects()
        {
            Stomach organ = new Stomach();
            Assert.That(organ is Object);
        }

        // Check that instance method is private
        [Test]
        public void PrivateExclamationIsPrivate()
        {
            Type t = typeof(Stomach);
            MethodInfo mInfo = t.GetMethod("PrivateExclamation",
                BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.That(mInfo.IsPrivate);
        }

        // Check a method's return type
        [Test]
        public void GrowlReturnsString()
        {
            Stomach organ = new Stomach();
            string noise = organ.Growl();
            Assert.That(noise, Is.InstanceOf(typeof(string)), "Expected Growl method to return a string");
        }

        // Check method's returned value
        [Test]
        public void GrowlReturnsSpecificString()
        {
            Stomach organ = new Stomach();
            string noise = organ.Growl();
            Assert.That(noise, Is.EqualTo("grrr"), "Expected Growl method to return 'grrr'");
        }

        // Check method's return value with multiple cases
        // Technically we should use TestCaseData class, but this is quicker
        // https://github.com/nunit/docs/wiki/TestCaseData
        [Test]
        public void DigestDecrementsContents()
        {
            Stomach organ = new Stomach();
            int start1 = organ.contents;

            int actual1 = organ.Digest(1);
            int expected1 = start1 - 1;

            int start2 = organ.contents;

            int actual2 = organ.Digest(3);
            int expected2 = start2 - 3;

            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
        }

        // Check that property exists
        [Test]
        public void BloodTypePropertyExists()
        {
            Stomach organ = new Stomach();
            Assert.That(organ, Has.Property("BloodType"));
        }

        // Check that field exists
        // Has.Property constraint does not work with fields,
        // so we use Throws.Nothing
        [Test]
        public void ContentsFieldExists()
        {
            Stomach organ = new Stomach();
            Assert.That(() => organ.contents, Throws.Nothing);
        }

    }
}
