/// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
pub fn count_bits(n: i32) -> Vec<i32> {
    let mut v: Vec<i32> = vec![];
    for i in 0..=n {
        v.push(i.count_ones() as i32);
    }
    return v;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((vec![0, 1, 1], 2));
        data.push((vec![0, 1, 1, 2, 1, 2], 5));

        for kvp in data.into_iter() {
            let res = count_bits(kvp.1);
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}.\n",
                kvp.1, kvp.0, res
            );
        }
    }
}
