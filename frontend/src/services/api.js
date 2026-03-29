const API_URL = process.env.REACT_APP_API_URL;
export async function createCustomer(customerData) {
  const response = await fetch(`${API_URL}/customers`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(customerData),
  });
  return response.json();
}

export async function getCustomers() {
  const response = await fetch(`${API_URL}/customers`);
  return response.json();
}
