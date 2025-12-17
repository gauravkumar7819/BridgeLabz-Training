class Solution {
    public static void main(String[] args) {
        Solution sol = new Solution();
        int[] arr = {3,2,2,3};
        int target = 3;
        int newLength = sol.removeElement(arr, target);
        System.out.println("New length: " + newLength);
        System.out.print("Modified array: ");
        for (int i = 0; i < newLength; i++) {
            System.out.print(arr[i] + " ");
        }
    }
public int removeElement(int[] arr, int target) {
int k=0;
int p=0;
for (int i = 0; i < arr.length; i++) {
        if(arr[i]!=target) {
                    arr[k]=arr[i];
                    k++;
                            }
                            else{
                                p++;
                            }
                                }


return arr.length-p;
}
}