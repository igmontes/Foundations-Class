using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        int NumItems = 1;   // used to get a total of all items
        int index = 0;      // used when entering items
        int icount = 0;     // used for changing items
        string strx;        // used for capturing the user's selection from the menu
        int optx;           // used for casting the user's selection

        // create an array of the ItemData struct
        ItemData[] itemdata = new ItemData[100];

        // use a never ending loop
        while (true)
        {
            // Options to choose from
            Console.WriteLine("Please select an option from the menu below");

            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items");
            Console.WriteLine("5. Quit");

            Console.Write("\nEnter your selection: ");

            strx = Console.ReadLine();   // read user's input
            
            // in case we have a blank value or they add text
            if (strx == ""  || 
                (strx != "1" && 
                 strx != "2" && 
                 strx != "3" &&
                 strx != "4" &&
                 strx != "5"))
            {
                optx = 0;
            }	
            else
            {
                optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            }


            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        Console.Write("Please enter the item Number: ");
                        itemdata[index].itemIDNo = int.Parse(Console.ReadLine());

                        Console.Write("Please enter the item Description: ");
                        itemdata[index].sDescription = Console.ReadLine();

                        Console.Write("Please enter the item Price: ");
                        itemdata[index].dblPricePerItem = double.Parse(Console.ReadLine());

                        Console.Write("How many do we have On Hand? ");
                        itemdata[index].iQuantityOnHand = int.Parse(Console.ReadLine());

                        Console.Write("Our Cost Per Item? ");
                        itemdata[index].dblOurCostPerItem = double.Parse(Console.ReadLine());

                        Console.Write("Actual value of the item? ");
                        itemdata[index].dblValueOfItem = double.Parse(Console.ReadLine());

                        index++;

                        Console.WriteLine();

                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No: ");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;
                        icount = 0;

                        foreach (ItemData b in itemdata)
                        {
                            if (b.itemIDNo == chgid)
                            {
                                fFound = true;

                                // Update the record
                                Console.WriteLine("What would you like to change?");

                                Console.WriteLine("a. ID #");
                                Console.WriteLine("b. Description");
                                Console.WriteLine("c. Price");
                                Console.WriteLine("d. Quantity On Hand");
                                Console.WriteLine("e. Our Cost");
                                Console.WriteLine("F. Value");

                                Console.Write("\nEnter your selection: ");
                                string change = Console.ReadLine();

                                if (change == "a" || change == "A")
                                {
                                    Console.Write("Please enter a new Item ID#: ");
                                    itemdata[icount].itemIDNo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Item ID has been update");
                                    Console.WriteLine();
                                }

                                if (change == "b" || change == "B")
                                {
                                    Console.Write("Please enter a new Description: ");
                                    itemdata[icount].sDescription = Console.ReadLine();
                                    Console.WriteLine("Item Description has been update");
                                    Console.WriteLine();
                                }

                                if (change == "c" || change == "C")
                                {
                                    Console.Write("Please enter a new Item Price: ");
                                    itemdata[icount].dblPricePerItem = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Item Price has been update");
                                    Console.WriteLine();
                                }

                                if (change == "d" || change == "D")
                                {
                                    Console.Write("Please enter Quantity On Hand: ");
                                    itemdata[icount].iQuantityOnHand = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Item Quantity has been update");
                                    Console.WriteLine();
                                }

                                if (change == "e" || change == "E")
                                {
                                    Console.Write("Please enter our new Cost: ");
                                    itemdata[icount].dblOurCostPerItem = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Item Cost has been update");
                                    Console.WriteLine();
                                }


                                if (change == "f" || change == "F")
                                {
                                    Console.Write("Please enter new Item Value: ");
                                    itemdata[icount].dblValueOfItem = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Item Value has been update");
                                    Console.WriteLine();
                                }
                            }
                            icount++;
                        }
                        

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                            Console.WriteLine();
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No: ");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fDeleted = false;
                        icount = 0;


                        ItemData[] newArray = new ItemData[100];

                        foreach (ItemData y in itemdata)
                        {
                            if (y.itemIDNo == chgid)
                            {
                                fDeleted = true;

                                itemdata[icount].itemIDNo = 0;
                                break;
                            }

                            icount++;  // increment the index
                        }

                        icount = 0;
                        if (!fDeleted) // if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (ItemData z in itemdata)
                            {
                                if (z.itemIDNo != 0)
                                {
                                    newArray[icount].itemIDNo = itemdata[icount].itemIDNo;
                                    newArray[icount].sDescription = itemdata[icount].sDescription;
                                    newArray[icount].dblPricePerItem = itemdata[icount].dblPricePerItem;
                                    newArray[icount].iQuantityOnHand = itemdata[icount].iQuantityOnHand;
                                    newArray[icount].dblOurCostPerItem = itemdata[icount].dblOurCostPerItem;
                                    newArray[icount].dblValueOfItem = itemdata[icount].dblValueOfItem;
                                }
                                icount++;
                            }
                            Array.Copy(newArray, itemdata, 100);

                        }
                        Console.WriteLine("Item has been deleted. Please press ENTER.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    }

                case 4:  //list all items
                    {
                        NumItems = 1;
                        Console.WriteLine("Item#  ItemID  Description           Price    QOH    Cost    Value");
                        Console.WriteLine("-----  ------  --------------------  -------  -----  ------  -------");

                        
                        foreach(ItemData x in itemdata)
                        {
                            if (x.itemIDNo <= 0)
                            {
                                
                                //break;
                            }
                            else
                            {
                                Console.WriteLine("{0,5} {1,7} {2,5} {3,15:C} {4,5} {5,6:C} {6,7:C}"
                                    , NumItems, x.itemIDNo, x.sDescription, x.dblPricePerItem, x.iQuantityOnHand, x.dblOurCostPerItem, x.dblValueOfItem);

                                NumItems++;
                            }
                        }
                        Console.WriteLine();
                        Console.Write("Please press ENTER");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    }


                case 5: //quit the program
                    {
                        Console.Write("Are you sure that you want to quit(y/n)? ");
                        string strresp = Console.ReadLine();

                        if (strresp == "y" || strresp == "yes" )
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again. ");
                        break;
                    }

            } //switch

        } //while true loop

    } //Main

} //MyInventory
