

String[] changedArray(String[] arr){
    int newLength = 0;

    for(int i = 0;i < arr.Length;i++){
        if(arr[i].Length <= 3){
            newLength = newLength + 1;
        }
    }

    String[] res = new String[newLength];
    int j = 0;

    for(int i = 0;i < arr.Length;i++){
        if(arr[i].Length <= 3){
            res[j] = arr[i];
            j = j + 1;
        }
    }
    return res;
}

String[] words = {"dog","hello","believe","hi","1","cat","sometimes","210000"};

Console.WriteLine("{0}", string.Join(" ", words));
Console.WriteLine("{0}", string.Join(" ",changedArray(words)));
