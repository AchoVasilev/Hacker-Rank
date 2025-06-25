    public static long repeatedString(String s, long n) {
    // Write your code here
        if(s.length() == 1 && s.charAt(0) == 'a') {
            return n;
        }

        long count = 0;
        for(int i = 0; i < s.length(); i++) {
            if(s.charAt(i) == 'a') {
                count++;
            }
        }

        long divPart = n / s.length();
        long divRemainder = n % s.length();

        count *= divPart;
        for(int i = 0; i < divRemainder; i++) {
            if (s.charAt(i) == 'a') {
                count++;
            }
        }

        return count;
    }
