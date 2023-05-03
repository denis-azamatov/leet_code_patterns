/// You are climbing a staircase. It takes n steps to reach the top.
/// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
pub fn climbing_stairs(n: i32) -> i32 {
    if n == 1 {
        return 1;
    }

    let mut arr = (1, 2);

    for _ in 3..n + 1 {
        arr = (arr.1, arr.0 + arr.1);
    }

    arr.1
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((1, 1));
        data.push((2, 2));
        data.push((8, 5));

        for kvp in data.into_iter() {
            let res = climbing_stairs(kvp.1.clone());
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}.\n",
                kvp.1, kvp.0, res
            );
        }
    }
}
