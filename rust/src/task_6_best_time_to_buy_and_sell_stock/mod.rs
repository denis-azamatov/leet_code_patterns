/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
/// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
pub fn max_profit(prices: Vec<i32>) -> i32 {
    let mut max_income = 0;
    let mut min_price = i32::MAX;

    for price in prices {
        if price < min_price {
            min_price = price
        } else if price - min_price > max_income {
            max_income = price - min_price
        }
    }
    return max_income;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test() {
        let mut data = Vec::with_capacity(2);
        data.push((5, vec![7, 1, 5, 3, 6, 4]));
        data.push((0, vec![7, 6, 4, 3, 1]));

        for kvp in data.into_iter() {
            let res = max_profit(kvp.1.clone());
            assert_eq!(
                res, kvp.0,
                "Error with set {:?}. Expected result {:?}. Actual result {:?}.\n",
                kvp.1, kvp.0, res
            );
        }
    }
}
