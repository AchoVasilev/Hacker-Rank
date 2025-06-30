public static int hourglassSum(List<List<Integer>> arr) {
    // Write your code here
        int maxSum = Integer.MIN_VALUE;
        for(int row = 0; row < arr.size() - 2; row++) {
            List<Integer> cols = arr.get(row);
            
            for(int col = 0; col < cols.size() - 2; col++) {
                int currentNumCol = cols.get(col);
                int nextNumCol = cols.get(col + 1);
                int lastNumCol = cols.get(col + 2);
                
                int middleNum = arr.get(row + 1).get(col + 1);
                int firstNumRow = arr.get(row + 2).get(col);
                int middleNumRow = arr.get(row + 2).get(col + 1);
                int lastNumRow = arr.get(row + 2).get(col + 2);
                
                int currentSum = currentNumCol + nextNumCol + lastNumCol + middleNum + firstNumRow + middleNumRow + lastNumRow;
                
                if(currentSum > maxSum) {
                    maxSum = currentSum;
                }
            }
        }
        
        return maxSum;
    }
