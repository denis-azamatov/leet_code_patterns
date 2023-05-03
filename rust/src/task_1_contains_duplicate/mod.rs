use std::collections::HashSet;

/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
pub fn contains_duplicate(nums: Vec<i32>) -> bool {
    return nums.len() != HashSet::<_>::from_iter(nums).len();
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((false, vec![1, 2, 3, 4]));
        data.push((true, vec![1, 2, 3, 1]));

        for kvp in data.into_iter() {
            let res = contains_duplicate(kvp.1.clone());
            assert_eq!(res, kvp.0, "Error with set {:?}. Expected result {:?}. Actual result {:?}", kvp.1, kvp.0, res);
        }
    }
}