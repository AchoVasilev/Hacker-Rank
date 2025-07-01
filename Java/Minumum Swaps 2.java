    static int minimumSwaps(int[] arr) {
//1352467
//1325467
//1235467
//1234567
        int swaps = 0;
        for(int i = 0; i < arr.length - 1; i++) {
            int nextIdx = i + 1;
            if(nextIdx != arr[i]) {
                while(arr[nextIdx] != i + 1) {
                    nextIdx++;
                }
                
                int temp = arr[nextIdx];
                arr[nextIdx] = arr[i];
                arr[i] = temp;
                swaps++;
            }
        }

        return swaps;
    }
