use std::cmp::Ordering;

///  Given an array nums of n integers where nums\[i] is in the range \[1, n\], return an array of all the integers in the range \[1, n\] that do not appear in nums.
///  ## Solution
///  Invert items by index = value - 1. Than return index + 1 where value > 0.
pub fn find_all_numbers_disappeared_in_an_array(nums: Vec<i32>) -> Vec<i32> {
    let mut nums = nums;

    for i in 0..nums.len() {
        let j = (nums[i].abs() - 1) as usize;
        nums[j] = -nums[j].abs();
    }

    return nums
        .iter()
        .enumerate()
        .filter_map(|(i, num)| match num.cmp(&0) {
            Ordering::Greater => Some(i as i32 + 1),
            _ => None,
        })
        .collect();
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((vec![2], vec![1, 1]));

        for kvp in data.into_iter() {
            let res = find_all_numbers_disappeared_in_an_array(kvp.1.clone());
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}",
                kvp.1, kvp.0, res
            );
        }
    }
}
