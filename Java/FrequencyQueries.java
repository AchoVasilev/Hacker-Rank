    static List<Integer> freqQuery(List<List<Integer>> queries) {
       
        Map<Integer, Integer> freqMap = new HashMap<>();
        Map<Integer, Integer> coutMap = new HashMap<>();
        List<Integer> result = new ArrayList<>();

        for (List<Integer> query : queries) {
            int operation = query.get(0);
            int current = query.get(1);
            switch (operation) {
                case 1:
                    int currentFreq = freqMap.getOrDefault(current, 0);
                    int newFreq = currentFreq + 1;
                    freqMap.put(current, newFreq);

                    coutMap.put(currentFreq, coutMap.getOrDefault(currentFreq, 0) - 1);
                    coutMap.put(newFreq, coutMap.getOrDefault(newFreq, 0) + 1);
                    break;
                case 2:
                    Integer oldFreq = freqMap.getOrDefault(current, 0);
                    if (oldFreq > 0) {
                        int nextFreq = oldFreq - 1;
                        freqMap.put(current, nextFreq);

                        coutMap.put(oldFreq, coutMap.getOrDefault(oldFreq, 0) - 1);
                        coutMap.put(nextFreq, coutMap.getOrDefault(nextFreq, 0) + 1);

                        if (nextFreq <= 0) {
                            freqMap.remove(current);
                        }
                    }
                    break;
                case 3:
                    boolean hasValues = coutMap.getOrDefault(current, 0) > 0;
                    result.add(hasValues ? 1 : 0);
                    break;
            }
        }

        return result;
    }
