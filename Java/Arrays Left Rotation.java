    public static List<Integer> rotLeft(List<Integer> a, int d) {
    // Write your code here
        if(d == a.size()) {
            return a;
        }
        
        List<Integer> arr = new ArrayList<>(a.size());
        for(int i = 0; i < a.size(); i++) {
            arr.add(0);
        }
        
        for(int i = 0; i < a.size(); i++) {
            arr.set(i, a.get((i + d) % a.size()));
        }
        
        return arr;
    }
