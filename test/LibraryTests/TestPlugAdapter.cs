using NUnit.Framework;
using System;
using AdapterExample;
namespace Test
{
    public class TestPlugAdapter
    {
        //Testo de la clase adapter para comprobar el correcto funcionamiento de los metodos on y off
        [Test]
        public void TestOff()
        {
            Plug plug = new Plug("1");
            PlugAdapter plugAdapter = new PlugAdapter(plug);
            plugAdapter.On();
            plugAdapter.Off();
            Assert.AreEqual("off", plugAdapter.GetStatus());
        }
        [Test]
        public void TestOn()
        {
            Plug plug = new Plug("2");
            PlugAdapter plugAdapter = new PlugAdapter(plug);
            plugAdapter.Off();
            plugAdapter.On();
            Assert.AreEqual("on", plugAdapter.GetStatus());
        }
        //Testo del on y off del lavarropas
        [Test]
        public void WashingMachineOn()
        {
            WashingMachine washingMachine = new WashingMachine("1");
            washingMachine.Off();
            washingMachine.On();
            Assert.AreEqual("on", washingMachine.GetStatus());
        }
        [Test]
        public void WashingMachineOff()
        {
            WashingMachine washingMachine = new WashingMachine("2");
            washingMachine.On();
            washingMachine.Off();
            Assert.AreEqual("off", washingMachine.GetStatus());
        }
        //Testo del on y off de la lampara
        [Test]
        public void BulbOn()
        {
            Bulb bulb = new Bulb("1");
            bulb.Off();
            bulb.On();
            Assert.AreEqual("on", bulb.GetStatus());
        }
        [Test]
        public void BulbOff()
        {
            Bulb bulb = new Bulb("2");
            bulb.On();
            bulb.Off();
            Assert.AreEqual("off", bulb.GetStatus());
        }
    }
}