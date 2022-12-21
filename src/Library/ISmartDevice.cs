//----------------------------------------------------------------------------------
// <copyright file="AdapterExample.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------------
namespace AdapterExample
{
    /// <summary>
    /// Una interface para todos los dispositivos inteligentes
    /// </summary>
    // Esta clase interface implementa el patron ISP (Interface Segregation Principle) debido a que 
    // todos los metodos que implementa esta clase todos los demas clases las usan y no hay metodos que no se usen, 
    // por ejemplo un metodo wash que solo se usaria en la clase WashingMachine.
    public interface ISmartDevice
    {         

        /// <summary>
        /// Enciende el dispositivo.
        /// </summary>        
        void On();  
        
        /// <summary>
        /// Apaga el dispositivo.
        /// </summary>          
        void Off();

        /// <summary>
        /// Estado el dispositivo.
        /// </summary>  
        string GetStatus();
        
    }// Tambien aplicamos el patron polimorfismo ya que todas las clases que implementan esta interface
    // ademas se creo una lista en el programa principal que contiene objetos de tipo ISmartDevice, para porbar 
    // que hubo una implementacion de polimorfismo.
}