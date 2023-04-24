Console.WriteLine("Enter No of robbers: ");
int num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the robber with whon sam will start shooting: ");
int Start = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the gap between robbers: ");
int gap = Convert.ToInt16(Console.ReadLine());
int[] arr1 = new int[num];
int CurrentIndex = Start - 1;
int ShotsCompleted = 0;
        for (int i = 0; i < num; i++)
        {
            arr1[i] = i + 1;
        }
        while (num != 0)
        {
            if (CurrentIndex >= num)
            {
                 CurrentIndex = CurrentIndex % num;
            }
            Console.WriteLine($"Target = {arr1[CurrentIndex]} , {++ShotsCompleted} shots completed");
                for (int i = CurrentIndex; i < num - 1; i++)
                {
                    arr1[i] = arr1[i + 1];
                }
                num--;
                CurrentIndex += gap;
        }
            Console.WriteLine(ShotsCompleted + " shots taken");


