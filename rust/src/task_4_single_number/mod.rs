/// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
pub fn single_number(nums: Vec<i32>) -> i32 {
    nums.iter().fold(0, |acc, x| acc ^ x)
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((1, vec![2, 2, 1]));
        data.push((4, vec![4, 2, 1, 2, 1]));
        data.push((1, vec![1]));

        for kvp in data.into_iter() {
            let res = single_number(kvp.1.clone());
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}",
                kvp.1, kvp.0, res
            );
        }
    }
}
