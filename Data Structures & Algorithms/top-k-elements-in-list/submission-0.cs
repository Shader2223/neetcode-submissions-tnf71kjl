public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int,int>();

        foreach(int n in nums){
            if (!count.ContainsKey(n)){count[n]=1;}
            else{ count[n]+=1;}
        }
        
        var heap = new PriorityQueue<int,int>();

        foreach(var c in count){
            heap.Enqueue(c.Key, c.Value);
            if (heap.Count > k){
                heap.Dequeue();
            }
        }

        int[] arr = new int[k];
        for(int i=0; i<arr.Length;i++){
            arr[i]=heap.Dequeue();
        }
        return arr;
    }
}
