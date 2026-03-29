import { useEffect, useState } from "react";
import { getCustomers } from "../services/api";

export default function CustomerList() {
  const [customers, setCustomers] = useState([]);

  useEffect(() => {
    async function fetchData() {
      const data = await getCustomers();
      setCustomers(data);
    }
    fetchData();
  }, []);

  return (
    <div>
      <h2>Registered Customers</h2>
      <table border="1" cellPadding="5">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Date Created</th>
            <th>Signature</th>
          </tr>
        </thead>
        <tbody>
          {customers.map((c) => (
            <tr key={c.id}>
              <td>{c.id}</td>
              <td>
                {c.firstName} {c.lastName}
              </td>
              <td>{c.email}</td>
              <td>{c.phoneNumber}</td>
              <td>{new Date(c.dateCreated).toLocaleString()}</td>
              <td>
                {c.signature ? (
                  <img src={c.signature} alt="signature" width="100" />
                ) : (
                  "—"
                )}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
