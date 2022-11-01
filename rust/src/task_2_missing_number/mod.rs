fn missing_number(nums: Vec<i32>) -> i32 {
    0
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