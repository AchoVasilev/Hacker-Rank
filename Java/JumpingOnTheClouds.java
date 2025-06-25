    public static int jumpingOnClouds(List<Integer> c) {
    // Write your code here
        int cloudIdx = 0;
        int jumps = 0;
        
        while(cloudIdx < c.size() - 1) {
            if(cloudIdx + 2 < c.size() && c.get(cloudIdx + 2) == 0) {
                cloudIdx += 2;
            } else {
                cloudIdx++;
            }
            
            jumps++;
        }
        
        return jumps;
    }
