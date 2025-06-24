class Result {

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<Integer> ar) {
    // Write your code here
        Map<Integer, Integer> sockMap = new HashMap<>();
        for(int i = 0; i < n; i++) {
            if(!sockMap.containsKey(ar.get(i))) {
                sockMap.put(ar.get(i), 0);
            }
            
            sockMap.put(ar.get(i), sockMap.get(ar.get(i)) + 1);
        }
        
        int count = 0;
        for(Map.Entry<Integer, Integer> entry : sockMap.entrySet()) {
            count += entry.getValue() / 2;
        }
        
        return count;
    }

}
