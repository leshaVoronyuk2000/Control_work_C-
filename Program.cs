

String[] changedArray(String[] arr){
    int newLength = 0;
    
    for(int i = 0;i < arr.Length;i++){
        if(arr[i].Length <= 3){
            newLength = newLength + 1;
        }
    }
}
