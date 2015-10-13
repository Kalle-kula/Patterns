using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class PlayWithRemote
    {
        static void Main(string[] args)
        {
            // Gets the ElectronicDevice to use:
            IElectronicDevice newDevice = TvRemote.getDevice();

            // TurnTVOn contains the command to turn on the tv
            // When execute() is called on this command object
            // it will execute the method on() in Television:
            TurnTvOn onCommand = new TurnTvOn(newDevice);

            // Calling the execute() causes on() to execute in Television
            DeviceButton onPressed = new DeviceButton(onCommand);

            // When press() is called theCommand.execute(); executes
            onPressed.press();
            //----------------------------------------------------------

            // Now when execute() is called off() of Television executes
            TurnTvOff offCommand = new TurnTvOff(newDevice);

            // Calling the execute() causes off() to execute in Television
            onPressed = new DeviceButton(offCommand);

            // When press() is called theCommand.execute(); executes
            onPressed.press();
            //----------------------------------------------------------

            // Now when execute() is called volumeUp() of Television executes
            TvTurnUpp volUppCommand = new TvTurnUpp(newDevice);

            // Calling the execute() causes volumeUp() to execute in Television
            onPressed = new DeviceButton(volUppCommand);

            // When press() is called theCommand.execute(); executes
            onPressed.press();
            onPressed.press();
            onPressed.press();
            //----------------------------------------------------------

            // Creating a TV and Radio to turn off with 1 press
            Television theTv = new Television();
            Radio theRadio = new Radio();

            // Add the Electronic Devices to a List
            List<IElectronicDevice> allDevices = new List<IElectronicDevice>();

            allDevices.Add(theTv);
            allDevices.Add(theRadio);

            // Send the List of Electronic Devices to TurnItAllOff
            // where a call to run execute() on this function will
            // call off() for each device in the list 
            TurnItAllOff turnOffDevices = new TurnItAllOff(allDevices);

            // This calls for execute() to run which calls for off() to
            // run for every ElectronicDevice
            DeviceButton turnThemOff = new DeviceButton(turnOffDevices);
            turnThemOff.press();
            //----------------------------------------------------------

            /*
             * It is common to be able to undo a command in a command pattern
             * To do so, DeviceButton will have a method called undo
             * Undo() will perform the opposite action that the normal
             * Command performs. undo() needs to be added to every class
             * with an execute()
             */
            turnThemOff.pressUndo();
            onPressed.pressUndo();
            // To undo more than one command add them to a LinkedList
            // using addFirst(). Then execute undo on each item until 
            // there are none left. (This is your Homework)
            Console.ReadLine();
        }
    }
}
