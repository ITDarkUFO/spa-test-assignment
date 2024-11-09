import { React, useState } from 'react'
import { Flex, Card, Typography, Space } from 'antd'
import DeleteButton from './DeleteProductButton'
import { useModal } from '../context/ModalContext';

const { Text, Paragraph } = Typography;

const ProductCard = ({ product, onDelete }) => {
    const { setViewEditModalVisible, setViewEditModalProductId } = useModal();

    const [isDeleted, setIsDeleted] = useState(false);

    const setTitle = () => {
        return (
            <Flex align="center" justify="space-between" style={{ marginTop: 5, marginBottom: 5 }}>
                <Flex vertical gap={2} style={{ width: "85%" }}>
                    <Text ellipsis="true" style={{ fontSize: 20 }}>{product.Name}</Text>
                    <Text type="secondary">{product.Vendorcode}</Text>
                </Flex>
                <DeleteButton productId={product.Id} onDelete={handleDelete} />
            </Flex>
        )
    }

    const handleDelete = () => {
        setIsDeleted(true);
        setTimeout(() => onDelete(product.Id), 500);
    }

    const onClickEvent = () => {
        setViewEditModalProductId(product.Id);
        setViewEditModalVisible(true);
    }

    return (
        <Card hoverable title={setTitle()} className={"card " + (isDeleted ? "fade-out" : "")}>
            <div className="card-body" onClick={onClickEvent}>
                <Flex vertical justify="space-between" style={{ minHeight: 'inherit' }}>
                    <Paragraph ellipsis={{ rows: 5 }} >{product.Description}</Paragraph>

                    <Flex align="flex-end" justify="space-between">
                        <Text style={{ fontSize: 18, maxWidth: "80%", lineHeight: "125%" }}>На складе {product.Quantity}&nbsp;ед.&nbsp;товара</Text>
                        <Text style={{ fontSize: 18, lineHeight: "125%" }}>{product.Price}&#8381;</Text>
                    </Flex>
                </Flex>

            </div>
        </Card>
    );
};

export default ProductCard;