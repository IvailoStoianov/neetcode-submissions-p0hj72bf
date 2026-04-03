/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int start = 1;
        int end = n;

        while (start <= end) {
            int middle = start + (end - start) / 2;
            int res = guess(middle);

            if (res == 0) {
                return middle;
            } else if (res < 0) {
                end = middle - 1;
            } else {
                start = middle + 1;
            }
        }

        return -1; // should never reach here if the number is guaranteed to be in the range
    }
}
