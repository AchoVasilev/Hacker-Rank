 public static int countingValleys(int steps, String path) {
        // Write your code here
        int valleyCount = 0;
        int level = 0;

        for(int i = 0; i < steps; i++) {
            if (path.charAt(i) == 'U') {
                level++;

                if(level == 0) {
                    valleyCount++;
                }
            } else {
                level--;
            }
        }

        return valleyCount;
    }
