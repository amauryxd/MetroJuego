using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        // Arrange
        //EnemyHealth prueba = new EnemyHealth();
        //int vidaSnapshot = prueba.vidaMaloso;

        // Act
        //prueba.vidaMaloso -= 1;

        // Assert
        //Assert.AreNotEqual(prueba.vidaMaloso, vidaSnapshot, "El enemigo Recibio un golpe");
        //Assert.AreEqual(prueba.vidaMaloso, vidaSnapshot, "El enemigo no reicibio un golpe");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
