using UnityEngine;

public class Part_1 : MonoBehaviour
{
    /*
     * You will be presented with five different Arithmetic / Boolean problems, each one is worth 1pt.
     * Underneath each one there is a commented space, type in your answer in there
     */
    void Start()
    {
        //Example ==============================================
        //Question: What is the value of a? 

        int b = 0;

        // Answer: a was never declared
        //=====================================================

        //Part 1 (1pt) ==============================================
        //Question: What is the value of x? 

        int x = -1;
        int y = 0;
        int z = 20;

        y = 10 + 5;
        z /= 10;
        x += y + z;

        print("The answer to part 1 is " + x);

        // Answer: x = 16
        //=====================================================

        //Part 2 (1pt) ==============================================
        //Question: What is the value of isTrue at the end of this? 

        bool isTrue = true;
        x = 144 / 12;
        y = 48 / 4;
        isTrue = x == y;

        print("The answer to part 2 is " + isTrue);

        // Answer: isTrue = true
        //=====================================================

        //Part 3 (1pt) ==============================================
        //Question: What is the value of x at the end of this for loop?

        x = 0;
        for (int i = 0; i < 10; i++)
        {
            x += i;
        }

        print("The answer to part 3 is " + x);

        // Answer: x = 45
        //=====================================================

        //Part 4 (1pt) ==============================================
        //Question: What is the value of x after this if statement?

        x = 0;
        string name = "Ash";
        if (name.Length > 5)
        {
            x = 1;
        }
        else if (name == "Ketchum")
        {
            x = 2;
        }
        else if (name.Length < 5)
        {
            x = 3;
        }
        else if (name.Contains("A"))
        {
            x = 4;
        }
        else
        {
            x = 5;
        }

        print("The answer to part 4 is " + x);

        // Answer: x = 3
        //=====================================================

        //Part 5 (1pt) ==============================================
        //Question: What is the restult of this for loop? 

        int[] a = new int[3] { 1, 3, 5 };
        try
        {
            for (int i = 0; i < 10; i++)
            {
                a[i] = i;
            }
        }
        catch (System.Exception e)
        {
            print("The answer to part 5 is " + e);
        }

        // Answer: Index out of bounds error, loop attempts to access index 3 of the array, but index 3 does not exist
        //=====================================================

    }

}
