/// Given an integer array nums, handle multiple queries of the following type
/// Calculate the sum of the elements of nums between indices left and right inclusive where left less or equal right
/// Implement the NumArray class:
/// NumArray(int[] nums) Initializes the object with the integer array nums.
struct NumArray {
    sums: Vec<i32>,
}

impl NumArray {
    fn new(nums: Vec<i32>) -> Self {
        let mut sums = Vec::with_capacity(nums.len());
        nums.into_iter().fold(0, |acc, cur| {
            sums.push(acc + cur);
            acc + cur
        });
        return NumArray { sums };
    }

    fn sum_range(&self, left: i32, right: i32) -> i32 {
        let mut result = self.sums[right as usize];
        if left > 0 {
            result -= self.sums[left as usize - 1]
        }
        result
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((1, vec![-2, 0, 3, -5, 2, -1], 0, 2));
        data.push((-1, vec![-2, 0, 3, -5, 2, -1], 2, 5));
        data.push((-3, vec![-2, 0, 3, -5, 2, -1], 0, 5));

        for kvp in data.into_iter() {
            let num_array = NumArray::new(kvp.1.clone());
            let res = num_array.sum_range(kvp.2, kvp.3);
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}.\n",
                kvp.1, kvp.0, res
            );
        }
    }
}
