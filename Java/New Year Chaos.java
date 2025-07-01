   public static void minimumBribes(List<Integer> q) {
    // Write your code here
        boolean isChaotic = false;
        int count = 0;
        for(int i = q.size() - 1; i >= 0; i--) {
            int currentEl = q.get(i);
            if (currentEl - (i + 1) > 2) {
                isChaotic = true;
                break;
            }

            int start = Math.max(0, q.get(i) - 2);
            for(int j = start; j < i; j++) {
                if (q.get(j) > q.get(i)) {
                    count++;
                }
            }
        }

        System.out.println(isChaotic ? "Too chaotic" : count);
    }
