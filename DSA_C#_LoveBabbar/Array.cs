class ArrayDs{
    public static void main(){
        Console.WriteLine("Hello Array");

        int[] arr1 = new int[] { 1, 2, 3,} ;
        foreach(int i in arr1){
            Console.WriteLine(i);
        }
        for (int i = 0;i<arr1.Length;i++)
        {
            Console.WriteLine(arr1[i]);
        }
    }
}