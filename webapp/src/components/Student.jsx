import { Button, ButtonGroup, Table } from "react-bootstrap"

function RowInfo(item) {
    let rowItem = item.item;
    return (<tr>
        <td>{rowItem.id}</td>
        <td>{rowItem.fName}</td>
        <td>{rowItem.lname}</td>
        <td>{rowItem.phone}</td>
        <td>{rowItem.parentPhone}</td>
        <td>{rowItem.address}</td>
        <td>{rowItem.description}</td>
        <td>
            <ButtonGroup aria-label="operation" size="sm" dir="ltr">
                <Button variant="outline-danger">حذف</Button>
                <Button variant="outline-secondary">ویرایش</Button>
            </ButtonGroup>
        </td>
    </tr>)
}

function StudentManager({ data }) {
    return (<Table size="sm" striped hover bordered variant="light" responsive>
        <thead>
            <tr>
                <th>کد</th>
                <th>نام</th>
                <th>نام خانوادگی</th>
                <th>تلفن</th>
                <th>تلفن والدین</th>
                <th>آدرس</th>
                <th>توضیحات</th>
                <th>عملیات</th>
            </tr>
        </thead>
        <tbody>
            {data.map(item => <RowInfo item={item} key={item.id} />)}
        </tbody>
    </Table>)
}

export default StudentManager