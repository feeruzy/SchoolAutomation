function StudentManager({ data }) {
    return data.map(item => <div key={item.id}>{item.address}</div>)
}

export default StudentManager