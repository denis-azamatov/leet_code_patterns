/// Given an array nums containing n distinct numbers in the range \[0, n\], return the only number in the range that is missing from the array.
/// ## Solution
/// Sum of numbers in range \[0, n\] - Sum of numbers in given array
fn missing_number(nums: Vec<i32>) -> i32 {
    let n = nums.len() as i32;
    let sum: i32 = nums.into_iter().sum();
    return (n + 1) * n / 2 - sum;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(3);
        data.push((2, vec![3, 0, 1]));
        data.push((2, vec![0, 1]));
        data.push((8, vec![9, 6, 4, 2, 3, 5, 7, 0, 1]));

        for kvp in data.into_iter() {
            let res = missing_number(kvp.1.clone());
            assert_eq!(res, kvp.0, "Error with set {:?}. Expected result {}. Actual result {}", kvp.1, kvp.0, res);
        }
    }
}